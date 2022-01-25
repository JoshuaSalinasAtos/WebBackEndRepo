
using api.Grpc;
using AutoMapper;
using Grpc.Core;
using WebCourseRepo.Dtos;
using WebCourseRepo.Services;

namespace WebBackEndRepo.Remote.Grpc.Server.Services;

public class GrpcCoursesService : GrpcCourses.GrpcCoursesBase
{
    private readonly ICourseService _service;
    private readonly IMapper _mapper;

    public GrpcCoursesService(ICourseService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    public override async Task<GetByIdsResponse> GetByIds(GetByIdsRequest request, ServerCallContext context)
    {
        GetByIdsResponse response = new GetByIdsResponse();
        List<CourseDto> dtos = await _service.FindByIds(request.Ids.ToList());
        foreach (var dto in dtos)
        {
            response.Courses.Add(
                _mapper.Map<CourseDto, Course>(dto)
                );
        }
        return response;
    }
}