using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
   [SerializeField]
   private AudioSource fundo, menuPrincipal, seleçãoCenário;

   public void SomMenuPrincipal(){
    menuPrincipal.Play();
   }

   public void SomFundo() {
    fundo.Play();
   }

   public void SomSeleçãoCenário() {
      seleçãoCenário.Play();
   }


   public void pausarSomFundo() {
    fundo.Stop();
   }

   public void PausarSomMenu() {
    menuPrincipal.Stop();
   }
}
