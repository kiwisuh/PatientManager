using System;
using System.Collections;
using System.Collections.Generic;
public class Users : IEnumerable<User>
{
    private List<User> users = new List<User>();
    User default_user = new User("", 0, "");
    public Users(string name, int age, string healthConcern)
    {
        users.Add(new User(name, age, healthConcern));
    }
    public User findByUserName(string name)
    {
        User result;
        result = users.Find(x => x.GetName() == name);
        return result;
    }
    public void addUser(string name, int age, string healthConcern)
    {
        users.Add(new User(name, age, healthConcern));
    }

    public void removeUser(string user_name)
    {
        User result;
        result = users.Find(x => x.GetName() == user_name);
        users.Remove(result);
    }
    public int getNumberOfUsers()
    {
        return users.Count;
    }

    public IEnumerator<User> GetEnumerator()
    {
        return users.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return users.GetEnumerator();
    }
}


