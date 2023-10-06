using AutoMapper;
using BlogApplication.Application.DTOs.Comment;
using BlogApplication.Application.DTOs.Post;
using BlogApplication.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApplication.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Post, PostDto>().ReverseMap();
            CreateMap<Post, UpdatePostDto>().ReverseMap();
            CreateMap<Post, CreatePostDto>().ReverseMap();
            CreateMap<Comment, CommentDto>().ReverseMap();
            CreateMap<Comment, CreateCommentDto>().ReverseMap();


        }
    }
}
