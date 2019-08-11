using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        #region Readonly Fields

        private readonly ICourseRepository _courseRepository;

        #endregion

        #region Constructor

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        #endregion

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel
            {
                Courses = _courseRepository.GetCourses()
            };
        }
    }
}
