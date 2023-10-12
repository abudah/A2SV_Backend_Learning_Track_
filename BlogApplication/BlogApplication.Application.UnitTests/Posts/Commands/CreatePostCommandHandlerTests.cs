using AutoMapper;
using BlogApplication.Application.DTOs.Post;
using BlogApplication.Application.Features.Posts.Handlers.Commands;
using BlogApplication.Application.Features.Posts.Requests.Commands;
using BlogApplication.Application.Persistence.Contracts;
using BlogApplication.Application.Profiles;
using BlogApplication.Application.Responses;
using BlogApplication.Application.UnitTests.Mocks;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BlogApplication.Application.UnitTests.Posts.Commands
{
    public class CreatePostCommandHandlerTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IPostRepository> _mockRepo;
        private readonly CreatePostDto _createPostDto;
        private readonly CreatePostCommandHandler _handler;



        public CreatePostCommandHandlerTests()
        {
            _mockRepo = MockPostRepository.GetPostRepository();
            var mapperConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<MappingProfile>();
            });
            _mapper = mapperConfig.CreateMapper();
            _handler = new CreatePostCommandHandler(_mockRepo.Object, _mapper);

            _createPostDto = new CreatePostDto
            {
                Title = "This is the Test Post twenty one",
                Content = "Test Content twenty one"
            };

        }
        [Fact]
        public async Task Valid_Post_Added()
        {
            var result = await _handler.Handle(new CreatePostCommand() {CreatePostDto = _createPostDto}, CancellationToken.None);

            var posts = await _mockRepo.Object.GetList();

            result.ShouldBeOfType<BaseCommandResponse>();

            posts.Count.ShouldBe(3);

        }
        
        public async Task InValid_Post_Added()
        {
            _createPostDto.Title = null;

            ValidationException ex = await Should.ThrowAsync<ValidationException>
                (async () =>
                { await _handler.Handle(new CreatePostCommand() { CreatePostDto = _createPostDto }, CancellationToken.None); }
                );

            var posts = await _mockRepo.Object.GetList();

            posts.Count.ShouldBe(2);
            ex.ShouldNotBeNull();
        }
    }
}
