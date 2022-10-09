<script>
  import { initpage, pezzi } from "../../lib/js/pasticceria";
  initpage();
</script>

<svelte:head>
  <title>Home</title>
  <link rel="stylesheet" href="/css/why.css" />
</svelte:head>
<br/>
<h1 class="tit">Cupcake</h1>
<br/>
<div class="" align="center">
  <div class="uk-card uk-card-default" id="card">
    <hr />
    <img src="/images/Cupcake.jpg" alt="" class="imgcenter" />
    <div>
      <div class="uk-card-body">
        <p class="det" style="color:black;">
          Questo dolcetto usato per accompagnare il The delle cinque, è
          diventato una vera icona culinaria USA. Cucinato fin dai primi dell'
          800 in tazzine che ne davano la forma, in tempi moderni i pirottini
          han sostituito le tazzine e i cupcake hanno acquisito una glassatura
          colorata e attraente che li rende uno diverso dall'altro. Buon
          Appetito!
        </p>
      </div>
    </div>
  </div>

  <br/>
  <button
    class="uk-button uk-button-primary carbut"
    id="Cupcake"
    on:click={() => pezzi("Cupcake")}>Aggiungi al carrello</button
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
