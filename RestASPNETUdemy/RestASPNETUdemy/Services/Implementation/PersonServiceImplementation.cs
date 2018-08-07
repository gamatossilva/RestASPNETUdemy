﻿using System;
using System.Collections.Generic;
using System.Threading;
using RestASPNETUdemy.Model;

namespace RestASPNETUdemy.Services.Implementation {
    public class PersonServiceImplementation : IPersonService {

        // volatile = quando a aplicação roda, começa do zero
        private volatile int count;

        public Person Create(Person person) {
            return person;
        }

        public void Delete(long id) {
            
        }

        public List<Person> FindAll() {
            List<Person> persons = new List<Person>();
            for(int i = 0; i < 8; i++) {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

        private Person MockPerson(int i) {
            return new Person {
                Id = IncrementAndGet(),
                FirstName = "Person Name " + i,
                LastName = "Person Lastname" + i,
                Address = "Some Address " + i,
                Gender = "Male"
            };
        }

        private long IncrementAndGet() {
            return Interlocked.Increment(ref count);
        }

        public Person FindById(long id) {
            return new Person {
                Id = IncrementAndGet(),
                FirstName = "Leandro",
                LastName = "Costa",
                Address = "Uberlandia - MG - Brasil",
                Gender = "Male"
            };
        }

        public Person Update(Person person) {
            return person;
        }
    }
}
