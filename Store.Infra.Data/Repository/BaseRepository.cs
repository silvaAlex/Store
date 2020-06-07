using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Store.Domain.Interfaces;
using Store.Infra.Cross.DTO.Interfaces;
using Store.Infra.Data.Context;
using System;
using System.Linq;

namespace Store.Infra.Data.Repository
{
    public class BaseRepository<TEntity, TEntityDTO> : IBaseRepository<TEntity, TEntityDTO>
        where TEntity : class
        where TEntityDTO : IEntityDTO
    {
        protected readonly IMapper mapper;
        protected readonly StoreContext storeContext;
        protected readonly DbSet<TEntity> DbSet;

        public BaseRepository(IMapper mapper,StoreContext storeContext)
        {
            this.mapper = mapper;
            this.storeContext = storeContext;
            DbSet = storeContext.Set<TEntity>();
        }

        public void Add(TEntityDTO entity)
        {
            var mappedEntity = mapper.Map<TEntity>(entity);
            DbSet.Add(mappedEntity);
            storeContext.SaveChanges();
        }

        public void Dispose()
        {
            storeContext.Dispose();
            GC.SuppressFinalize(this);
        }

        public IQueryable<TEntityDTO> GetAll()
        {
            return DbSet.ProjectTo<TEntityDTO>(mapper.ConfigurationProvider);
        }

        public TEntityDTO GetById(int id)
        { 
            var entity = DbSet.Find(id);
            var mappedEntity = mapper.Map<TEntityDTO>(entity);
            return mappedEntity;
        }

        public void Remove(int id)
        {
            var entity = DbSet.Find(id);
            var mappedEntity = mapper.Map<TEntity>(entity);
            DbSet.Remove(mappedEntity);
            storeContext.SaveChanges();
        }

        public void Update(TEntityDTO entity)
        {
            var mappedEntity = mapper.Map<TEntity>(entity);
            storeContext.Entry(mappedEntity).State = EntityState.Modified;
            storeContext.SaveChanges();
        }
    }
}
