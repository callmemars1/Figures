SELECT p.name, c.name FROM products p
LEFT JOIN product_categories pc on p.id = pc.product_id
LEFT JOIN categories c on c.id = pc.category_id