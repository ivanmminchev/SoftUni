function solve(product, quantity) {
  let result = 0;
  if (product === 'coffee') {
    result = 1.5 * quantity;
  } else if (product === 'water') {
    result = 1 * quantity;
  } else if (product === 'coke') {
    result = 1.4 * quantity;
  } else if (product === 'snacks') {
    result = 2 * quantity;
  }

  return (result = result.toFixed(2));
}

console.log(solve('water', 5));
