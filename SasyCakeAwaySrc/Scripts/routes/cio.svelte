<script>
  import { initpage, biscotti } from "../lib/js/pasticceria";
  initpage();
</script>

<svelte:head>
  <title>Home</title>
  <link rel="stylesheet" href="/css/why.css" />
</svelte:head>
<br />
<h1 class="tit">Bicchierini di cioccolato riempiti con creme a scelta</h1>
<br />
<div class="" align="center">
  <div class="uk-card uk-card-default" id="card">
    <!-- <div class="uk-card-media-left uk-cover-container">
           
        </div> -->
    <br />
    <img
      class="imgcenter"
      src="/images/Bicchierini al cioccolato.jpg"
      alt=""
      width="128"
    />

    <div>
      <div class="uk-card-body">
        <p class="det">
          Da ragazzi eravamo soliti frequentare una cremeria posta lontano dai
          riflettori del centro di Torino. Situata piuttosto in periferia ma
          molto famosa nel quartiere. Sono rimasta folgorata da questi
          pasticcini atipici, unici per l'epoca. Ancora oggi è difficile trovare
          chi li proponga. Memore di quel gusto unico, ho voluto riprodurre
          questa specialità particolarmente golosa, che unisce il gusto intenso
          del cioccolato con il sapore avvolgente della crema, e una spruzzata
          di panna come ciliegina sulla torta. Naturalmente anche in questo caso
          si possono personalizzare con un ripieno di crema che soddisfi il
          proprio gusto: zabaglione, pistacchio, caffè, nocciola, sono tutte
          valide alternative.
        </p>
      </div>
    </div>
  </div>

  <br />
  <button
    class="uk-button uk-button-primary carbut"
    id="Bicchierini al cioccolato"
    on:click={() => biscotti("Bicchierini al cioccolato")}
    >Aggiungi al carrello</button
  >
  <br />
  <div class="testo">
    <p class="citprod" style="color:rgb(195, 0, 255)">
      "Da ragazza sono rimasta folgorata da questi pasticcini atipici. Memore di
      quel gusto unico, ho voluto riprodurre questa specialità particolarmente
      golosa"
    </p>
  </div>
  <br />
</div>

<style>
  .uk-card {
    width: 80%;
  }
  .imgcenter {
    width: 350px;
  }
</style>
