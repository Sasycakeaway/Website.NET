<script>
  import { initpage, biscotti } from "../../lib/js/pasticceria";
  initpage();
</script>

<svelte:head>
  <title>Home</title>
  <link rel="stylesheet" href="/css/why.css" />
</svelte:head>
<br/>
<h1 class="tit">Piccidde’t castelluccese</h1>
<br/>
<div class="" align="center">
  <div class="uk-card uk-card-default" id="card">
    <hr />
    <img src="/images/Piccidde’t castelluccese.jpg" alt="" class="imgcenter" />
    <div>
      <div class="uk-card-body">
        <p class="det" style="color:black;">
          E' il dolce che più mi ricorda la mia infanzia. Nasco da mamma lucana
          e babbo pugliese. E, da sempre, Pasqua non è Pasqua senza il
          Piccidde't lucano. Da un impasto di uova e farina si crea un pane
          semidolce adatto a una colazione all'italiana, o, come era abituato il
          nonno, abbinandolo agli ottimi salumi del paese. Semplicemente
          meraviglioso!
        </p>
      </div>
    </div>
  </div>

  <br/>
  <button
    class="uk-button uk-button-primary carbut"
    id="Piccidde’t castelluccese"
    on:click={() => biscotti("Piccidde’t castelluccese")}>Aggiungi al carrello</button
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
