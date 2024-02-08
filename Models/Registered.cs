using M2E_conseiller.Enums;

namespace M2E_conseiller.Models;

public class Registered
{
    public int Id { get; set; }
    //public string BNI { get; set; }
    public string Lastname { get; set; }
    public string Firstname { get; set; }

    public bool IsCheckedIn { get; set; } = false;
    /*public string Email { get; set; }
    public string Phone { get; set; }
    public ModalityType Modality { get; set; }*/




}