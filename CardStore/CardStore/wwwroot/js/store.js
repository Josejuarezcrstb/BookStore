// Sample client-side product list for the static store page
const products = [
  { name: 'Pikachu V', game: 'Pokemon', price: 12.99 },
  { name: 'Charizard Holo', game: 'Pokemon', price: 199.99 },
  { name: 'Black Lotus (Proxy)', game: 'Magic', price: 999.99 },
  { name: 'Lightning Bolt', game: 'Magic', price: 2.5 },
  { name: 'Riftbound Champion', game: 'Riftbound', price: 8.0 },
  { name: 'Riftbound Shard', game: 'Riftbound', price: 3.5 }
];

function renderProducts(list) {
  const tbody = document.querySelector('#productsTable tbody');
  tbody.innerHTML = '';
  for (const p of list) {
    const tr = document.createElement('tr');
    tr.innerHTML = `<td>${p.name}</td><td>${p.game}</td><td>$${p.price.toFixed(2)}</td>`;
    tbody.appendChild(tr);
  }
}

function applyFilters() {
  const game = document.getElementById('gameFilter').value;
  const sort = document.getElementById('priceSort').value;
  const search = document.getElementById('searchInput').value.trim().toLowerCase();

  let filtered = products.filter(p => {
    return (game === 'all' || p.game === game) && (p.name.toLowerCase().includes(search));
  });

  if (sort === 'asc') filtered.sort((a,b) => a.price - b.price);
  if (sort === 'desc') filtered.sort((a,b) => b.price - a.price);

  renderProducts(filtered);
}

document.addEventListener('DOMContentLoaded', () => {
  renderProducts(products);
  document.getElementById('gameFilter').addEventListener('change', applyFilters);
  document.getElementById('priceSort').addEventListener('change', applyFilters);
  document.getElementById('searchInput').addEventListener('input', applyFilters);
});
