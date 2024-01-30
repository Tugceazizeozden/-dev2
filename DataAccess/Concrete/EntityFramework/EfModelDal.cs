using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;
internal class EfModelDal : IModelDal

{
 private readonly RentACarContext _context;

    public  EfModelDal(RentACarContext context) 
    {
        _context = context; 
    }

    public Model  Add (Model entity   )
    {
        _context.Entry(entity).State = EntityState.Added;


        _context.SaveChanges();

        return entity;  
    }

    public Model Delete(Model entity , bool isSoftDelete= true) { 
       entity.DeletedAt = DateTime.UtcNow;
    if (isSoftDelete) { }
        _context.Models.Remove(entity);
        _context.Entry(entity).State = EntityState.Modified;



        _context.SaveChanges();
        return entity;  


    }


    

    public Model? Get(Func<Model, bool> predicate) {

        _context.Models.FirsOrDefault(predicate);


        return model; 

    }
    




    }

public IList<Model> GetList(Func<Model, bool>? predicate = null) {

    IQueryable<Model> query = _context..Set<Model>();
    if (predicate != null) { }
    query = query.Where(predicate).AsQueryable();
    return query.ToList();     
}

    
        
      
    
    

    public Model Update(Model entity)
    {

    entity.UpdateAt = DateTime.UtcNow;
    _context.Models.Update(entity);
    _context.SaveChanges();
    return entity;  
    }

