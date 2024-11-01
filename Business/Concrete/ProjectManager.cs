﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccessLayer.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProjectManager : IProjectService
    {
        private readonly IProjectDal _projectDal;
        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }
        public void Delete(Project t)
        {
            _projectDal.Delete(t);  
        }

        public List<Project> GetAll()
        {
            return _projectDal.GetAll();
        }

        public Project GetById(int id)
        {
            return _projectDal.GetById(id);
        }

        public List<Project> GetAllByUserId(int userId,int page)
        {
            return _projectDal.GetAllByUserId(userId,page);
        }

        public Project Insert(Project t)
        {
            return _projectDal.Insert(t);
        }

        public void Update(Project t)
        {
            _projectDal.Update(t);
        }

		public Project GetByIdWithTasks(int id)
		{
            return _projectDal.GetByIdWithTasks(id);
		}

		
		public List<Project> GetAllWithCommander(int page)
		{
            return _projectDal.GetAllWithCommander(page);
		}

		public int GetPageCount(int userId)
		{
			return _projectDal.GetPageCount(userId);
		}

		public Project GetByIdWithRelations(int id)
		{
			return _projectDal.GetByIdWithRelations(id);
		}

		public int GetPageCount()
		{
            return _projectDal.GetPageCount();
		}
	}
}
