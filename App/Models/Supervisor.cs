namespace inheratanceDiner.Models {
  class Supervisor : Server {

    public void MakeScheduale () {

    }

    public override void Discount () {
      System.Console.WriteLine ("A 15% discount");
    }
    public Supervisor (string name, string id) : base (name, id) {

    }
  }
}