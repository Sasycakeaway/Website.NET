<script>
  import { initpage, biscotti } from "../../lib/js/pasticceria";
  initpage();
</script>

<svelte:head>
  <title>Home</title>
  <link rel="stylesheet" href="/css/why.css" />
</svelte:head>
<br />
<h1 class="tit">Strudel tradizionale di Mele</h1>
<br />
<div class="" align="center">
  <div class="uk-card uk-card-default" id="card">
    <hr />
    <img
      src="/images/Strudel tradizionale di Mele.jpg"
      alt=""
      class="imgcenter"
    />
    <div>
      <div class="uk-card-body">
        <p class="det" style="color:black;">
          Lo strudel è un dolce tipico del Trentino Alto Adige, ma le sue
          origini sono turche. Gli Ungheresi, dominati dai turchi hanno
          realizzato per primi lo strudel che oggi è diventato il dolce
          tradizionale dei paesi altoatesini. Qui si trovano le mele che assieme
          a uvetta, pinoli e cannella rendono inimitabile il suo sapore. Io
          propongo la variante tradizionale con la frolla. Gustatelo con una
          tazza fumante di vin brulé, e inebriatevi del suo profumo intenso!
        </p>
      </div>
    </div>
  </div>

  <br />
  <button
    class="uk-button uk-button-primary carbut"
    id="Strudel tradizionale di Mele"
    on:click={() => biscotti("Strudel tradizionale di Mele")}
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
    width: 400px;
  }
</style>
