using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;
internal class EfusersDal : IusersDal

{
 private readonly RentACarContext _context;

    public  EfusersDal(RentACarContext context) 
    {
        _context = context; 
    }

    public users  Add (users entity   )
    {
        _context.Entry(entity).State = EntityState.Added;


        _context.SaveChanges();

        return entity;  
    }

    public users Delete(users entity , bool isSoftDelete= true) { 
       entity.DeletedAt = DateTime.UtcNow;
    if (isSoftDelete) { }
        _context.userss.Remove(entity);
        _context.Entry(entity).State = EntityState.Modified;



        _context.SaveChanges();
        return entity;  


    }


    

    public users? Get(Func<users, bool> predicate) {

        _context.userss.FirsOrDefault(predicate);


        return users; 

    }
    




    }

public IList<users> GetList(Func<users, bool>? predicate = null) {

    IQueryable<users> query = _context..Set<users>();
    if (predicate != null) { }
    query = query.Where(predicate).AsQueryable();
    return query.ToList();     
}

    
        
      
    
    

    public users Update(users entity)
    {

    entity.UpdateAt = DateTime.UtcNow;
    _context.userss.Update(entity);
    _context.SaveChanges();
    return entity;  
    }

