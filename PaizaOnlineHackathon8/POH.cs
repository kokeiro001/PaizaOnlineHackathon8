namespace PaizaOnlineHackathon8 {

  public abstract class PaizaOnlineHackathon {
    protected abstract void ReadInput();
    protected abstract void Calclate();
    protected abstract void Output();

    public void Run() {
      ReadInput();
      Calclate();
      Output();
    }
  }
}
