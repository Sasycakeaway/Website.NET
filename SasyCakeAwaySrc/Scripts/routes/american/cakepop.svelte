<script>
  import { initpage, pezzi } from "../../lib/js/pasticceria";
  initpage();
</script>

<svelte:head>
  <title>Home</title>
  <link rel="stylesheet" href="/css/why.css" />
</svelte:head>
<br/>
<h1 class="tit">Cakepop</h1>
<br/>
<div class="" align="center">
  <div class="uk-card uk-card-default" id="card">
    <hr />
    <img src="/images/Cakepop.jpg" alt="" class="imgcenter" />
    <div>
      <div class="uk-card-body">
        <p class="det">
          Avete mai pensato di mangiare una torta a forma di gelato o di lecca
          lecca? Allora non avete mai visto un cake pop. Dolcetto sfizioso e
          divertente glassato di cioccolato e decorato con perline, zuccherini,
          granelle, ghiaccia reale, semplicemente magnifico.
        </p>
      </div>
    </div>
  </div>

  <br/>
  <button
    class="uk-button uk-button-primary carbut"
    id="Cakepop"
    on:click={() => pezzi("Cakepop")}>Aggiungi al carrello</button
  >
  <br/>
  <!-- <p class="citprod" style="color:rgb(195, 0, 255)">"Preparare dolci è molto più che saper eseguire ricette: è un vero e proprio gesto d’amore"</p> -->
</div>

<style>
  .uk-card {
    width: 80%;
  }
  .imgcenter {
    width: 350px;
  }
</style>
