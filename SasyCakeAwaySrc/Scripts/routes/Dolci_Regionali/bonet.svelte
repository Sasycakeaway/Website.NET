<script>
  import { initpage, biscotti } from "../../lib/js/pasticceria";
  initpage();
</script>

<svelte:head>
  <title>Home</title>
  <link rel="stylesheet" href="/css/why.css" />
</svelte:head>
<br />
<h1 class="tit">Bonet piemontese</h1>
<br />
<div class="" align="center">
  <div class="uk-card uk-card-default" id="card">
    <hr />
    <img src="/images/Bonet piemontese.jpg" alt="" class="imgcenter" />
    <div>
      <div class="uk-card-body">
        <p class="det" style="color:black;">
          Il tipico budino della tradizione piemontese fatto con uova, zucchero,
          cacao, latte, liquore (nella ricetta originale veniva usato il fernet)
          e amaretti secchi. Il bonet, il cui nome significa “cappello”, era
          appunto l’ultima pietanza che veniva alla fine, come il cappello,
          uscendo da una casa o da un ristorante, era l’ultima cosa ad essere
          indossata. Insomma un bonet a fine pranzo… quando si dice chiudere in
          bellezza!.
        </p>
      </div>
    </div>
  </div>

  <br />
  <button
    class="uk-button uk-button-primary carbut"
    id="Bonet piemontese"
    on:click={() => biscotti("Bonet piemontese")}>Aggiungi al carrello</button
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
