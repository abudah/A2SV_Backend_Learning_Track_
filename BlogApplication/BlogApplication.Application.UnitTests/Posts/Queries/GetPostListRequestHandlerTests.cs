using AutoMapper;
using BlogApplication.Application.DTOs.Post;
using BlogApplication.Application.Features.Posts.Handlers.Queries;
using BlogApplication.Application.Features.Posts.Requests.Queries;
using BlogApplication.Application.Persistence.Contracts;
using BlogApplication.Application.Profiles;
using BlogApplication.Application.UnitTests.Mocks;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApplication.Application.UnitTests.Posts.Queries
{
    public class GetPostListRequestHandlerTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IPostRepository> _mockRepo;
        public GetPostListRequestHandlerTests()
        {
            _mockRepo = MockPostRepository.GetPostRepository();

            var mapperConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<MappingProfile>();
            });

            _mapper = mapperConfig.CreateMapper();
        }

        [Fact]
        public async Task GetPostListTest()
        {
            var handler = new GetPostListRequestHandler(_mockRepo.Object, _mapper);

            var result = await handler.Handle(new GetPostListRequest(), CancellationToken.None);

            result.ShouldBeOfType<List<PostDto>>();
        }
    }
}
