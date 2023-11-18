select p.name as productName, c.name as categoryName
from products p left join productInCategory pc on (pc.product_id = p.product_id)
                left join categories c on (c.category_id = pc.category_id)
