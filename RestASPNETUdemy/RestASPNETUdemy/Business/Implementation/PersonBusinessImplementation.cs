﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using RestASPNETUdemy.Data.Converters;
using RestASPNETUdemy.Data.VO;
using RestASPNETUdemy.Model;
using RestASPNETUdemy.Model.Context;
using RestASPNETUdemy.Repository;
using RestASPNETUdemy.Repository.Generic;

namespace RestASPNETUdemy.Business.Implementation {
    public class PersonBusinessImplementation : IPersonBusiness {

        private IRepository<Person> _repository;

        private readonly PersonConverter _converter;

        public PersonBusinessImplementation(IRepository<Person> repository) {
            _repository = repository;
            _converter = new PersonConverter();
        }

        public PersonVO Create(PersonVO person) {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Create(personEntity);
            return _converter.Parse(personEntity);
        }

        public void Delete(long id) {
            _repository.Delete(id);
        }

        public List<PersonVO> FindAll() {
            return _converter.ParseList(_repository.FindAll());
        }

        public PersonVO FindById(long id) {
            return _converter.Parse(_repository.FindById(id));
        }

        public PersonVO Update(PersonVO person) {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Update(personEntity);
            return _converter.Parse(personEntity);
        }


        public bool Exists(long id) {

            return _repository.Exists(id);

        }

    }
}