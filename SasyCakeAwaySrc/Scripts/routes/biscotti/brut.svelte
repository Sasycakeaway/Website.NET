<script>
  import { initpage, biscotti } from "../../lib/js/pasticceria";
  initpage();
</script>

<svelte:head>
  <title>Home</title>
  <link rel="stylesheet" href="/css/why.css" />
</svelte:head>
<br />
<h1 class="tit">Brüt ma bon</h1>
<br />
<div class="" align="center">
  <div class="uk-card uk-card-default" id="card">
    <hr />
    <img src="/images/Brüt ma bon.jpg" alt="" class="imgcenter" />
    <div>
      <div class="uk-card-body">
        <p class="det">
          Alla fine dell'800 a Borgomanero venne sfornato un dolce davvero
          brutto da vedere (brüt) ma buonissimo nel gusto (bon). Ecco nascere i
          brüt ma bon piemontesi, che al contrario di quelli lombardi e toscani,
          han solo la nocciola come ingrediente base, anziche la mandorla. La
          vita è proprio un po’ così, alle volte ti riserva qualche brutta
          sorpresa ma poi arriva il buono dei miei dolcetti, e la giornata
          assume tutto un altro sapore!
        </p>
      </div>
    </div>
  </div>

  <br />
  <button
    class="uk-button uk-button-primary carbut"
    id="Brüt ma bon"
    on:click={() => biscotti("Brüt ma bon")}>Aggiungi al carrello</button
  >
  <br />
  <div class="testo">
    <p class="citprod" style="color:rgb(195, 0, 255)">
      "A chi non è mai capitato di se​ntirsi almeno una volta un brutto
      anatroccolo? Ma spesso l'apparenza inganna!"
    </p>
  </div>
  <br />
</div>

<style>
  .uk-card {
    width: 80%;
  }
  .imgcenter {
    width: 400px;
  }
</style>
