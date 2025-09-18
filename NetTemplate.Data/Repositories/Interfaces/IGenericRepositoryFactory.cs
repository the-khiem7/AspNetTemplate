﻿namespace NetTemplate.DAL.Repositories.Interfaces
{
    public interface IGenericRepositoryFactory
    {
        IGenericRepository<TEntity> GetRepository<TEntity>() where TEntity : class;


    }
}
