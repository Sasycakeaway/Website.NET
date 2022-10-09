<script>
  import { initpage, biscotti } from "../../lib/js/pasticceria";
  initpage();
</script>

<svelte:head>
  <title>Home</title>
  <link rel="stylesheet" href="/css/why.css" />
</svelte:head>
<br />
<h1 class="tit">Diamantini al cacao</h1>
<br />
<div class="divv" align="center">
  <div class="uk-card uk-card-default" id="card">
    <hr />
    <img src="/images/Diamantini.jpg" alt="" class="imgcenter" />
    <div>
      <div class="uk-card-body">
        <p class="det" style="color:black;">
          Se è vero che un diamante è per sempre, queste delizie sapranno
          conquistare il tuo cuore. Non sarà proprio come regalarne uno da 18
          carati, ma di sicuro farai felici i tuoi ospiti con una cascata di
          deliziose dolcezze. Cacao selezionato, burro e zucchero grezzo di
          canna rendono questo frollino irresistibile.
        </p>
      </div>
    </div>
  </div>

  <br />
  <button
    class="uk-button uk-button-primary carbut"
    id="Diamantini"
    on:click={() => biscotti("Diamantini")}>Aggiungi al carrello</button
  >
  <br />
  <!-- <p class="citprod" style="color:rgb(195, 0, 255)">"Preparare dolci è molto più che saper eseguire ricette: è un vero e proprio gesto d’amore"</p> -->
</div>
