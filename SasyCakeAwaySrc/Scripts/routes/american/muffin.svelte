<script>
  import { initpage, pezzi } from "../../lib/js/pasticceria";
  initpage();
</script>

<svelte:head>
  <title>Home</title>
  <link rel="stylesheet" href="/css/why.css" />
</svelte:head>
<br/>
<h1 class="tit">Muffin</h1>
<br/>
<div class="" align="center">
  <div class="uk-card uk-card-default" id="card">
    <hr />
    <img src="/images/Muffin.jpg" alt="" class="imgcenter" />
    <div>
      <div class="uk-card-body">
        <p class="det" style="color:black;">
          In principio il muffin era un dolcetto mignon, così piccolo da poter
          essere mangiato in un solo boccone. Attraversando l'oceano sono
          cresciuti e hanno assunto la forma che tutti conoscono e si è diffusa
          a tal punto che tre stati ne hanno uno ufficiale: il Minnesota quello
          ai mirtilli, il Massachusetts al mais, New York alle mele. Noi a
          Torino lo amiamo con pepite di cioccolato.
        </p>
      </div>
    </div>
  </div>

  <br/>
  <button
    class="uk-button uk-button-primary carbut"
    id="Muffin"
    on:click={() => pezzi("Muffin")}>Aggiungi al carrello</button
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
