<script>
  import { initpage, biscotti } from "../../lib/js/pasticceria";
  initpage();
</script>

<svelte:head>
  <title>Home</title>
  <link rel="stylesheet" href="/css/why.css" />
</svelte:head>
<br/>
<h1 class="tit">Canestrelli</h1>
<br/>
<div class="" align="center">
  <div class="uk-card uk-card-default" id="card">
    <hr />
    <img src="/images/Canestrelli.jpg" alt="" class="imgcenter" />
    <div>
      <div class="uk-card-body">
        <p class="det">
          Con la loro consistenza friabile ed il sapore irresistibile del burro,
          i Canestrelli si sciolgono in bocca e rivelano tutto il gusto e le
          sensazioni di una tradizione antica ed affascinante che li ha fatti
          diventare uno dei dolci della cucina ligure più famosi ed apprezzati.
          Incerto è l'origine del nome. Probabilmente si riferisce al
          contenitore in cui si facevano raffredare o forse allo stampo a forma
          floreale in cui venivano cotti. Quale che sia la corretta
          interpretazione, i dolcetti sono stati inseriti nell'elenco dei
          Prodotti Agroalimentari Tradizionali (PAT) della Ligura.
        </p>
      </div>
    </div>
  </div>

  <br/>
  <button
    class="uk-button uk-button-primary carbut"
    id="Canestrelli"
    on:click={() => biscotti("Canestrelli")}>Aggiungi al carrello</button
  >
  <br/>
  <div class="testo">
    <p class="citprod" style="color:rgb(195, 0, 255)">
      "Un fiore friabile di frolla e zucchero a velo tutto da gustare!"
    </p>
  </div>
  <br/>
</div>

<style>
  .uk-card {
    width: 80%;
  }
  .imgcenter {
    width: 320px;
  }
</style>
