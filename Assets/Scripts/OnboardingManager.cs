using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnboardingManager : MonoBehaviour
{
    // Variabel untuk menampung panel kita dari Unity
    public GameObject Panel_Welcome;
    public GameObject Panel_Umur;
    public GameObject Panel_Negara;


    // Fungsi ini akan dipanggil oleh tombol "Mulai"
    public void TekanTombolMulai()
    {
        // Sembunyikan panel welcome
        Panel_Welcome.SetActive(false);

        // Tampilkan panel umur
        Panel_Umur.SetActive(true);
    }

    public void TekanTombolLanjutUmur()
    {
        // (Nanti di sini kita bisa menyimpan data umurnya)

        // Sembunyikan panel umur
        Panel_Umur.SetActive(false);

        // Tampilkan panel negara
        Panel_Negara.SetActive(true);
    }
}
