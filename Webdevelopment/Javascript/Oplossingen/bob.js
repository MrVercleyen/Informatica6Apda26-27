function bob(prompt) {
  if (
    prompt === "" ||
    prompt === undefined ||
    prompt === null ||
    prompt.trim() == ""
  ) {
    return "Prima. Doe maar!";
  }
  if (prompt.endsWith("?") && isUpperCase(prompt)) {
    return "Rustig maar, ik weet wat ik doe!";
  }
  if (prompt.endsWith("?")) {
    return "Tuurlijk.";
  }
  if (isUpperCase(prompt)) {
    return "Wauw, kalm aan!";
  }
  return "Maakt niet uit.";
}

function isUpperCase(str) {
  return str === str.toUpperCase();
}
