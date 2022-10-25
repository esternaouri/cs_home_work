//q9-----------------------------------
class Person
{
    private string _name;
    private int _age;

  public Person (string name)
    {
        _name=name;        
         
    }
      public Person (string name, int age) :this(name)
    {
        _age=age;        
         
    }
  public string GetName()
    {
        return _name;        
         
    }

        public int GetAge()
    {
        return _age;        
         
    }
   

}
   