<script>
  import { initpage, biscotti } from "../../lib/js/pasticceria";
  initpage();
</script>

<svelte:head>
  <title>Home</title>
  <link rel="stylesheet" href="/css/why.css" />
</svelte:head>
<br />
<h1 class="tit">Canestrelli</h1>
<br />
<div class="" align="center">
  <div class="uk-card uk-card-default" id="card">
    <hr />
    <img src="/images/Canestrelli.jpg" alt="" class="imgcenter" />
    <div>
      <div class="uk-card-body">
        <p class="det">
          La storia di questi dolci secchi alle mandorle è antichissima: già i
          soldati romani mangiavano una specie di pane dolce, aromatizzato
          all’anice o al finocchio cotto al forno, tagliato in maniera obliqua a
          metà cottura e rimesso in forno a biscottare (cioè a cuocere due volte
          per mantenere una conservazione più lunga). Così oggi possiamo gustare
          una vera e propria delizia da annegare nel Vin Santo.
        </p>
      </div>
    </div>
  </div>

  <br />
  <button
    class="uk-button uk-button-primary carbut"
    id="Canestrelli"
    on:click={() => biscotti("Canestrelli")}>Aggiungi al carrello</button
  >
  <br />
  <div class="testo" />
  <br />
</div>

<style>
  .uk-card {
    width: 80%;
  }
  .imgcenter {
    width: 320px;
  }
</style>
