<script>
  import { initpage, biscotti } from "../../lib/js/pasticceria";
  initpage();
</script>

<svelte:head>
  <title>Home</title>
  <link rel="stylesheet" href="/css/why.css" />
</svelte:head>
<br />
<h1 class="tit">Meringhe</h1>
<br />
<div class="" align="center">
  <div class="uk-card uk-card-default" id="card">
    <hr />
    <img src="/images/Meringhe.jpg" alt="" class="imgcenter" />
    <div>
      <div class="uk-card-body">
        <p class="det">
          Dolce, friabile, spumosa, per decorare gelati e torte, o gustata in
          purezza, la meringa è un dolce semplice e delizioso. Il suo creatore
          fu Casparini, un pasticcere svizzero ma di origini italiane che ne
          realizzò una per conquistare il cuore della principessa Maria,
          promessa sposa del re Luigi XV. Bianca e soffice come la neve, questa
          specialità deve il suo nome alla cittadina svizzera Meiringen di cui
          era originario il Casparini, e qui, nel 1985, venne realizzata la più
          grande meringa del mondo, lunga due metri e mezzo, larga un metro e
          mezzo e alta 70 centimetri. Per realizzarla servirono circa 2000 uova,
          120 chili di zucchero a velo e 60 litri di panna montata. Numeri che
          le valsero l’iscrizione nel Guinnes dei primati.
        </p>
      </div>
    </div>
  </div>

  <br />
  <button
    class="uk-button uk-button-primary carbut"
    id="Meringhe"
    on:click={() => biscotti("Meringhe")}>Aggiungi al carrello</button
  >
  <br />
  <div class="testo">
    <p class="citprod" style="color:rgb(195, 0, 255)">
      "E la meringa un giorno si sposò con la panna montata: uno dei matrimoni
      più riusciti e duraturi della pasticceria europea!"
    </p>
  </div>
</div>

<style>
  .uk-card {
    width: 80%;
  }
  .imgcenter {
    width: 350px;
  }
</style>
