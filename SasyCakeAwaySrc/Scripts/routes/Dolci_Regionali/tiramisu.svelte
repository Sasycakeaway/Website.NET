<script>
  import { initpage, biscotti } from "../../lib/js/pasticceria";
  initpage();
</script>

<svelte:head>
  <title>Home</title>
  <link rel="stylesheet" href="/css/why.css" />
</svelte:head>
<br />
<h1 class="tit">Tiramisù</h1>
<br />
<div class="" align="center">
  <div class="uk-card uk-card-default" id="card">
    <hr />
    <img src="/images/Tiramisù.jpg" alt="" class="imgcenter" />
    <div>
      <div class="uk-card-body">
        <p class="det" style="color:black;">
          "Il tiramisù si può definire il dolce italiano per eccellenza, l'unico
          dolce al caffè di grande successo mondiale". In questa affermazione
          del Maestro pasticcere Iginio Massari è racchiusa tutta la bontà di
          questo dolce e la sua centenaria tradizione diffusa in tutta italia.
          Si può ordinare come torta o come comoda monoporzione.
        </p>
      </div>
    </div>
  </div>

  <br />
  <button
    class="uk-button uk-button-primary carbut"
    id="Tiramisù"
    on:click={() => biscotti("Tiramisù")}>Aggiungi al carrello</button
  >
  <br />
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
