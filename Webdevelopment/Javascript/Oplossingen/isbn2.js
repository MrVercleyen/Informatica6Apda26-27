let isbn = "3-598-21507-X";
let isbn2 = "3-598-21508-8";
let isbn3 = "3-598-22508-8";
console.log(isCorrectISBN(isbn));
console.log(isCorrectISBN(isbn2));
console.log(isCorrectISBN(isbn3));

function isCorrectISBN(isbncode) {
  console.log(isbncode);
  let isbnArray = isbncode.split("");
  console.log(isbnArray);

  let isbnGetallen = [];

  isbnArray.forEach((element) => {
    if (element !== "-") {
      if (element === "x" || element === "X") {
        isbnGetallen.push(10);
      } else {
        isbnGetallen.push(+element);
      }
    }
  });

  let formuleUitkomst = 0;
  for (let i = 0; i < isbnGetallen.length; i++) {
    formuleUitkomst += isbnGetallen[i] * (10 - i);
  }
  formuleUitkomst = formuleUitkomst % 11;

  if (formuleUitkomst === 0) {
    return `De ISBN ${isbncode} is een correcte ISBN waarde`;
  } else {
    return "De ISBN " + isbncode + " is geen correcte ISBN waarde";
  }
}
