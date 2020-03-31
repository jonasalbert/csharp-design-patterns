using System;

namespace Pattern_Bridge
{
    public class RepositoryLocation: Repository<Location>
    {
        public RepositoryLocation()
        {
            this.List.Add(new Location() { Id = Guid.NewGuid(), Name = "H.O.", Prime = 2 });
            this.List.Add(new Location() { Id = Guid.NewGuid(), Name = "Manila", Prime = 3 });
            this.List.Add(new Location() { Id = Guid.NewGuid(), Name = "Cebu", Prime = 5 });
            this.List.Add(new Location() { Id = Guid.NewGuid(), Name = "Davao", Prime = 7 });
        }
    }
}