using System;
using System.Linq;
using System.Collections.Generic;
using CarterAPI.Models;

namespace CarterAPI.Repositories
{
    public class RegisterRepository
    {
        public static Dictionary<int, Register> registers = new Dictionary<int, Register>();
        public List<Register> GetAll(){
            return registers.Values.ToList();
        }

        public Register Get(int id){
            return registers.GetValueOrDefault(id);

        }
     
        public void Add(Register register){
            registers.Add(register.Id, register);
        }

        public void Edit(Register register){
            registers.Remove(register.Id);
            registers.Add(register.Id, register);
        }

        public void Delete(int id){
            registers.Remove(id);
        }
    }
}