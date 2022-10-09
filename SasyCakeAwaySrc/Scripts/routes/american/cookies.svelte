<script>
  import { initpage, biscotti } from "../../lib/js/pasticceria";
  initpage();
</script>

<svelte:head>
  <title>Home</title>
  <link rel="stylesheet" href="/css/why.css" />
</svelte:head>
<br />
<h1 class="tit">Cookies</h1>
<br />
<div class="" align="center">
  <div class="uk-card uk-card-default" id="card">
    <hr />
    <img src="/images/Cookies.jpg" alt="" class="imgcenter" />
    <div>
      <div class="uk-card-body">
        <p class="det">
          Croccanti e dorati all’esterno, morbidi all’interno, con gocce di
          cioccolato fondente. E’ difficile resistere ai “Chocolate Chips
          Cookies” americani. Crispy, chewy, delicious! Nelle varianti
          classiche, al doppio cioccolato o al caffè, sono una vera delizia per
          il palato.
        </p>
      </div>
    </div>
  </div>

  <br />
  <button
    class="uk-button uk-button-primary carbut"
    id="Cookies"
    on:click={() => biscotti("Cookies")}>Aggiungi al carrello</button
  >
  <br />
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
