<script>
  import { initpage, biscotti } from "../../lib/js/pasticceria";
  initpage();
</script>

<svelte:head>
  <title>Home</title>
  <link rel="stylesheet" href="/css/why.css" />
</svelte:head>
<br />
<h1 class="tit">Baci di Dama</h1>
<br />
<div class="" align="center">
  <div class="uk-card uk-card-default" id="card">
    <hr />
    <img src="/images/Baci di dama.jpg" alt="" class="imgcenter" />
    <div>
      <div class="uk-card-body">
        <p class="det">
          Non c’è dolce più romantico e sensuale del bacio di dama: due calotte
          di biscotto si uniscono con un velo di cioccolato come due labbra
          intente a darsi un dolcissimo bacio! In origine il bacio di dama nasce
          a Tortona e presenta la mandorla come ingrediente di base. Nelle
          Langhe invece il prodotto di base delle due cialde è la nocciola, la
          tonda e gentile del Piemonte. Lasciatevi sedurre dal loro gusto
          travolgente e…. buoni baci a tutti
        </p>
      </div>
    </div>
  </div>

  <br />
  <button
    class="uk-button uk-button-primary carbut"
    id="Baci di dama"
    on:click={() => biscotti("Baci di dama")}>Aggiungi al carrello</button
  >
  <br />
  <div class="testo">
    <p class="citprod" style="color:rgb(195, 0, 255)">
      "Dammi mille baci, poi cento, poi ancora mille, poi di nuovo cento.... un
      bacio tira l'altro!"
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
