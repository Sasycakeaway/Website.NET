<script>
  import { initpage, pezzi } from "../../lib/js/pasticceria";
  initpage();
</script>

<svelte:head>
  <title>Home</title>
  <link rel="stylesheet" href="/css/why.css" />
</svelte:head>
<br />
<h1 class="tit">Zeppole di San Giuseppe</h1>
<br />
<div class="" align="center">
  <div class="uk-card uk-card-default" id="card">
    <hr />
    <img src="/images/Zeppole di San Giovanni.jpg" alt="" class="imgcenter" />
    <div>
      <div class="uk-card-body">
        <p class="det" style="color:black;">
          Le zeppole di San Giuseppe, come molti dolci della tradizione
          napoletana, si costruiscono su un fine contrasto di sapori. Un guscio
          di pasta bignè fritta o al forno, dal gusto neutro, custodisce una
          crema pasticcera densa, dolcissima e profumata, sulla cui sommità
          poggia un’amarena che conferisce una nota aspra. Ciuffi di panna per i
          più golosi.
        </p>
      </div>
    </div>
  </div>

  <br />
  <button
    class="uk-button uk-button-primary carbut"
    id="Zeppole di San Giovanni"
    on:click={() => pezzi("Zeppole di San Giovanni")}
    >Aggiungi al carrello</button
  >
  <br />
  <!-- <p class="citprod" style="color:rgb(195, 0, 255)">"Preparare dolci è molto più che saper eseguire ricette: è un vero e proprio gesto d’amore"</p> -->
</div>

<style>
  .uk-card {
    width: 80%;
  }
  .imgcenter {
    width: 300px;
  }
</style>
