import React, { useState, useRef, useCallback, useMemo } from "react";



// from a product listing page, and you want to allow users to search for products efficiently.


const ProductSearch = () => {
  const [searchTerm, setSearchTerm] = useState("");

  const prevSearchTerm = useRef(""); // Stores previous search term
  
  const products = ["Laptop", "Phone", "Tablet", "Smartwatch", "Headphones", "Speaker","Bottle"];

  // useCallback: Memoizes the filter function to prevent unnecessary re-creation
  const filterProducts = useCallback(
    (term) => {
      console.log("Filtering products..."); // Logs only when search term changes
      return products.filter((product) =>
        product.toLowerCase().includes(term.toLowerCase())
      );
    },
    [products] // Recomputes only if the product list changes
  );

  // useMemo: Stores filtered results without re-computation
  const filteredProducts = useMemo(() => filterProducts(searchTerm), [searchTerm, filterProducts]);

  return (
    <div>
      <h2>Search Products</h2>
      <input
        type="text"
        value={searchTerm}
        onChange={(e) => {
          prevSearchTerm.current = searchTerm; // Stores previous value before updating
          setSearchTerm(e.target.value);
        }}
        placeholder="Search..."
      />
      <p>Previous Search: {prevSearchTerm.current}</p>

      <h3>Results:</h3>
      <ul>
        {filteredProducts.map((product, index) => (
          <li key={index}>{product}</li>
        ))}
      </ul>
    </div>
  );
};

export default ProductSearch;
