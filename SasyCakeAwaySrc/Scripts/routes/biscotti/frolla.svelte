<script>
  import { initpage, biscotti } from "../../lib/js/pasticceria";
  initpage();
</script>

<svelte:head>
  <title>Home</title>
  <link rel="stylesheet" href="/css/why.css" />
</svelte:head>
<br />
<h1 class="tit">Biscotti di frolla con gli aromi dell' orto</h1>
<br />
<div class="" align="center">
  <div class="uk-card uk-card-default" id="card">
    <hr />
    <img
      src="/images/Biscotti di frolla con gli aromi dell'orto.jpg"
      alt=""
      class="imgcenter"
    />
    <div>
      <div class="uk-card-body">
        <p class="det">
          Con curiosità mi sono messa a sperimentare con i gusti dell'orto dopo
          una masterclass tenuta dal maestro Mario Bacilieri. Rosamarino, timo,
          basilico, salvia possono esaltare i sapori tradizionali trasformando
          un frollino tradizionale in un biscotto completamente nuovo. Un
          trionfo di gusto. Il mio preferito? Timo e Limone con una spruzzata di
          cristalli di zucchero. Travolgente!
        </p>
      </div>
    </div>
  </div>

  <br />
  <button
    class="uk-button uk-button-primary carbut"
    id="Biscotti di frolla con gli aromi dell'orto"
    on:click={() => biscotti("Biscotti di frolla con gli aromi dell'orto")}
    >Aggiungi al carrello</button
  >
  <br />
  <div class="testo">
    <p class="citprod" style="color:rgb(195, 0, 255)">
      "Timo, limone con una spruzzata di cristalli di zucchero, un gusto
      travolgente!"
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
