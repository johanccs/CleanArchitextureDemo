using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        #region Readonly Fields

        private UniversityDBContext _ctx;

        #endregion

        #region Constructor

        public CourseRepository(UniversityDBContext ctx)
        {
            _ctx = ctx;
        }

        public void Add(Course course)
        {
            _ctx.Courses.Add(course);
            _ctx.SaveChanges();
        }

        #endregion

        public IEnumerable<Course> GetCourses()
        {
            return _ctx.Courses;
        }
    }
}
