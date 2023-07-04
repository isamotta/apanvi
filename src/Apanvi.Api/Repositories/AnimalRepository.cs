using Apanvi.API.Context;
using Apanvi.API.Models;
using System.Collections.Concurrent;


namespace Apanvi.API.Repositories
{
    public class AnimalRepository : IAnimalRepository
    {

        private readonly ConnectionContext _context;

        public AnimalRepository(ConnectionContext context)
        {
            _context = context;
        }
        private ConcurrentBag<Animal> _animalsDb = new ConcurrentBag<Animal>();        
                public AnimalRepository()
        {
            _animalsDb.Add(new Animal
            {
                Id = 1,
                Name = "Name1",
                Description = "description",
                Size = Size.Small,
                Age = Age.Puppy,
                Species = Species.Cat,
                Genre = Genre.Male,
                
            });

            _animalsDb.Add(new Animal
            {
                Id= 2,
                Name = "Name2",
                Description = "description",
                Size = Size.Large,
                Age = Age.Adult,
                Species = Species.Dog,
                Genre = Genre.Female,

            });
            _animalsDb.Add(new Animal
            {
                Id= 3,
                Name = "Name3",
                Description = "description",
                Size = Size.Medium,
                Age = Age.Senior,
                Species = Species.Dog,
                Genre = Genre.Female,

            });
        }

        public List<Animal> GetAll(Species? species = null, Size? size = null, Age? age = null, Genre? genre = null)
        {
            var animals = _animalsDb.ToList();
            if (species.HasValue)
            {
                animals = animals.Where(animal => animal.Species == species).ToList();
            }
            if (size.HasValue)
            {
                animals = animals.Where(animal => animal.Size == size).ToList();
            }
            if (genre.HasValue)
            {
                animals = animals.Where(animal => animal.Genre == genre).ToList();
            }
            if (age.HasValue)
            {
                animals = animals.Where(animal => animal.Age == age).ToList();
            }

            return animals;
        }

        public List<Animal> GetByID(int id)
        {
            var animals = _animalsDb.ToList();
            var animalById = animals.Where(animal => animal.Id == id).ToList();
            return animalById;
            
        }


    }
    

    }

