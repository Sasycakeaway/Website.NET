<script>
  import { initpage, biscotti } from "../lib/js/pasticceria";
  initpage();
</script>

<svelte:head>
  <title>Home</title>
  <link rel="stylesheet" href="/css/why.css" />
</svelte:head>
<br />
<h1 class="tit">Bignole e Chantilly artigianali con creme a scelta</h1>
<br />
<div align="center">
  <div class="uk-card uk-card-default " id="card">
    <br />
    <img class="imgcenter" src="/images/Bignole.jpg" alt="" width="20" />
    <div>
      <div class="uk-card-body">
        <p class="det">
          La bignola è uno dei dolci tipici della pasticceria torinese e
          piemontese, diffusi a corte durante il regno sabaudo. Questi piccoli
          gusci di pasta rigonfia, dalla forma tondeggiante e ripieni di c​rema
          pasticcera sono un grande classico delle merende torinesi, dei pranzi
          della domenica, delle feste e delle ricorrenze. Io le propongo ripiene
          di creme a scelta, dalla classica crema pasticcera, crema zabaglione o
          crema alla nocciola, alle più moderne creme al pistacchio, al caffè o
          al cioccolato. Con glassa o senza, sono un modo gustoso per
          festeggiare insieme!
        </p>
      </div>
    </div>
  </div>
  <br />
  <button
    class="uk-button uk-button-primary carbut"
    id="Bignole"
    on:click={() => biscotti("Bignole")}>Aggiungi al carrello</button
  >
  <br />
  <div class="testo">
    <p class="citprod" style="color:rgb(195, 0, 255)">
      "Preparare dolci è molto più che saper eseguire ricette: è un vero e
      proprio gesto d’amore"
    </p>
  </div>
</div>

<style>
  .uk-card {
    width: 80%;
  }
  .imgcenter {
    width: 400px;
  }
</style>
