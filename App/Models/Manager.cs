namespace inheratanceDiner.Models {
  class Manager : Supervisor {

    public int PinCode { get; set; }

    public void TerminateEmployee () {

    }

    public void HireEmployee () {

    }

    public void Delegate () {
      System.Console.WriteLine ("Do My Work");
    }
    public override void Discount () {
      System.Console.WriteLine ("A 100% discount");
    }
    public Manager (string name, string id, int pinCode) : base (name, id) {

      PinCode = pinCode;
    }
  }
}