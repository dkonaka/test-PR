// Required namespaces for testing the HomeController
using AspNetCoreApp.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace AspNetCoreApp.Tests
{
    /// <summary>
    /// Unit tests for the HomeController class
    /// These tests verify that the controller actions return the expected results
    /// </summary>
    public class HomeControllerTests
    {
        // Mock of the logger to avoid actual logging during tests
        private readonly Mock<ILogger<HomeController>> _loggerMock;
        
        // Instance of the controller being tested
        private readonly HomeController _controller;

        /// <summary>
        /// Constructor that sets up the test environment before each test
        /// Creates a mock logger and initializes the HomeController with it
        /// </summary>
        public HomeControllerTests()
        {
            // Create a mock logger that can be used in tests
            _loggerMock = new Mock<ILogger<HomeController>>();
            
            // Initialize the controller with the mock logger
            _controller = new HomeController(_loggerMock.Object);
        }

        /// <summary>
        /// Tests that the Index action returns a ViewResult
        /// This verifies that the action will render a view when called
        /// </summary>
        [Fact]
        public void Index_ReturnsViewResult()
        {
            // Act - Call the Index method
            var result = _controller.Index();

            // Assert - Verify the result is a ViewResult
            Assert.IsType<ViewResult>(result);
        }

        /// <summary>
        /// Tests that the Privacy action returns a ViewResult
        /// This verifies that the action will render a view when called
        /// </summary>
        [Fact]
        public void Privacy_ReturnsViewResult()
        {
            // Act - Call the Privacy method
            var result = _controller.Privacy();

            // Assert - Verify the result is a ViewResult
            Assert.IsType<ViewResult>(result);
        }
    }
}