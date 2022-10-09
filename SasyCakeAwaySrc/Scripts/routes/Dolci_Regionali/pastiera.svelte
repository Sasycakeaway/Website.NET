<script>
  import { initpage, biscotti } from "../../lib/js/pasticceria";
  initpage();
</script>

<svelte:head>
  <title>Home</title>
  <link rel="stylesheet" href="/css/why.css" />
</svelte:head>
<br/>
<h1 class="tit">Pastiera Napoletana</h1>
<br/>
<div class="" align="center">
  <div class="uk-card uk-card-default" id="card">
    <hr />
    <img src="/images/Pastiera Napoletana.jpg" alt="" class="imgcenter" />
    <div>
      <div class="uk-card-body">
        <p class="det" style="color:black;">
          E' il dolce che a Pasqua contende il ruolo di re della tavola alla
          Colomba. Originaria di Napoli ha radici antichissime. Grano cotto,
          ricotta, canditi sono i suoi ingredienti principali. E la sua
          scioglievolezza al palato è un tripudio di gioia per i sensi.
        </p>
      </div>
    </div>
  </div>

  <br/>
  <button
    class="uk-button uk-button-primary carbut"
    id="Pastiera Napoletana"
    on:click={() => biscotti("Pastiera Napoletana")}>Aggiungi al carrello</button
  >
  <br/>
  <!-- <p class="citprod" style="color:rgb(195, 0, 255)">"Preparare dolci è molto più che saper eseguire ricette: è un vero e proprio gesto d’amore"</p> -->
</div>

<style>
  .uk-card {
    width: 80%;
  }
  .imgcenter {
    width: 400px;
  }
</style>
