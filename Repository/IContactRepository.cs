using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContacts;
internal interface IContactRepository

{
    DataTable SelectAll();
    DataTable SelectRow(int contactID);
    DataTable Search(string parameter);

    //if it will be successfull it return true
    bool Insert(string name, string family, string mobile, string email, string adress, int age);
    bool Update(int contactID, string name, string family, string mobile, string email, string adress, int age);
    bool Delete(int contactID);
}
