import { dialogs } from "svelte-dialogs";
import { v4 as uuidv4 } from "uuid";
import emailjs from "@emailjs/browser";
let user, pass, newordini;
function putorder(
  nome,
  cognome,
  indirizzo,
  cap,
  domicilio,
  email,
  pass,
  cart,
  totale
) {
  let regDate = new Date();
  let isodate = regDate.toISOString().split("T")[0];
  let id = uuidv4();
  var myHeaders = new Headers();
  myHeaders.append("Content-Type", "application/x-www-form-urlencoded");

  var urlencoded = new URLSearchParams();
  console.log(totale);
  urlencoded.append("id", id);
  urlencoded.append("nome", nome);
  urlencoded.append("cognome", cognome);
  urlencoded.append("indirizzo", indirizzo);
  urlencoded.append("cap", cap);
  urlencoded.append("domicilio", domicilio);
  urlencoded.append("totale", Math.round(totale));
  urlencoded.append("cart", cart);
  urlencoded.append("email", email);
  urlencoded.append("timestamp", isodate);

  var requestOptions = {
    method: "POST",
    headers: myHeaders,
    body: urlencoded,
    redirect: "follow",
  };

  fetch("/api/addorder", requestOptions)
    .then((response) => response.text())
    .then(async (result) => {
      if (result == "1") {
        try {
          await emailjs.send("service_ccwtjlr", "template_cavi0no", {
            id: id,
            nome: nome,
            cognome: cognome,
            indirizzo: indirizzo,
            email: email,
          });
          location.href = "/ecommerce/ordercomplete";
        } catch (error) {
          console.log(error);
        }
        sessionStorage.clear();
      }
    })
    .catch((err) => {
      dialogs.alert(
        "Errore durante la registrazione dell'ordine, contattarci, fornendo i dettagli del pagamento per richiedere il rimborso"
      );
      console.error(err);
    });
}
export async function init(
  totale,
  nome,
  cognome,
  indirizzo,
  cap,
  domicilio,
  email,
  pass,
  cart
) {
  emailjs.init("XI3aGphpOi4C1--qr");
  console.log(totale);
  try {
    await paypal_sdk
      .Buttons({
        createOrder: function (data, actions) {
          return actions.order.create({
            purchase_units: [
              {
                amount: {
                  value: totale,
                },
              },
            ],
          });
        },
        onApprove: function (data, actions) {
          console.log("approve");
          return actions.order.capture().then(async function (details) {
            putorder(
              nome,
              cognome,
              indirizzo,
              cap,
              domicilio,
              email,
              pass,
              cart,
              totale
            );
          });
        },
        onError: function (err) {
          dialogs.alert(
            "Errore durante la registrazione dell'ordine, contattarci, fornendo i dettagli del pagamento per richiedere il rimborso"
          );
        },
      })
      .render("#paypal");
  } catch (error) {
    console.error("failed to render the PayPal Buttons", error);
    // location.href= "/ecommerce/pagamenti";
  }
}
export function getorder(user, pass) {}

export function getvariable(username, password, ordinipass, ordineora) {
  user = username;
  password = pass;
  newordini = ordinipass;
  newordini.push(ordineora);
}
