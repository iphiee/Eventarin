﻿using System;
using NUnit.Framework;
using Moq;
using Eventarin.Core.Services;
using Should;
using Xamarin.Forms;
using Eventarin.Core.Pages;
using Eventarin.Core.ViewModels;
using System.Threading.Tasks;
using System.Collections;
using Eventarin.Core.Models;
using System.Collections.Generic;

namespace Eventarin.Core.Tests.ViewModels
{
	[TestFixture]
	public class SessionsViewModelTests
	{
		Mock<IWebService> _webService;
		SessionsViewModel viewModel;

		[SetUp]
		public void Init()
		{
			_webService = new Mock<IWebService>();
			viewModel = new SessionsViewModel(_webService.Object);
		}

		[Test]
		public void SessionsViewModel_Should_Inherit_From_BaseViewModel()
		{
			// Arrange

			// Act

			// Assert
			viewModel.ShouldImplement(typeof(BaseViewModel));
		}
			
		[Test]
		public void SessionsViewModel_RefreshCommand_Should_Call_GetSessions()
		{
			// Arrange
			var sessions = new List<Session>{ new Session(), new Session() } ;
			var result = new ServiceResult<IEnumerable<Session>> { Success = true, Data = sessions };
			_webService.Setup(x => x.GetSessions()).ReturnsAsync(result);

			// Act
			viewModel.RefreshCommand.Execute(null);

			// Assert
			_webService.Verify(x => x.GetSessions(), Times.Once);
			viewModel.Sessions.Count.ShouldEqual(sessions.Count);
		}

		[Test]
		public void SessionsViewModel_RefreshCommand_Should_Not_Get_Sessions_If_IsBusy()
		{
			// Arrange
			viewModel.IsBusy = true;

			// Act
			viewModel.RefreshCommand.Execute(null);

			// Assert
			_webService.Verify(x => x.GetSessions(), Times.Never);
		}
	}
}

