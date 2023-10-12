using BlogApplication.Application.Persistence.Contracts;
using BlogApplication.Domain;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApplication.Application.UnitTests.Mocks
{
    public static class MockPostRepository
    {
        public static Mock<IPostRepository> GetPostRepository()
        {
            var posts = new List<Post> {
                new Post
                    {
                        Id = 20,
                        Title = "This is the Test Post twenty",
                        Content = "Test Content twenty"
                    },
                    new Post
                    {
                        Id = 30,
                        Title = "This is the Test Post thirty",
                        Content = "Test Content thirty"                    }
            };

            var mockRepo = new Mock<IPostRepository>();

            mockRepo.Setup(r => r.GetList()).ReturnsAsync(posts);
            mockRepo.Setup(r => r.Add(It.IsAny<Post>())).ReturnsAsync((Post post) =>
            {
                posts.Add(post);
                return post;
            });

            return mockRepo;
        }
    }
}
