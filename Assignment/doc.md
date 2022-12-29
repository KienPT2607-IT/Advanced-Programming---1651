-   Source:
    https://github.com/GMOkeefe/ocp-templatemethod-lab/blob/master/src/lab/example/afterrefactoring/HouseTemplate.java
-   Another source:
    https://toihocdesignpattern.com/chuong-8-template-method-pattern.html

-   Scenario:
    One Tea là một cửa hàng chuyên bán đồ uống, được giới trẻ rất yêu thích. Mặt hàng chủ đạo của họ là các loại đồ uống được pha chế từ cà phê và trà. Chị Trang là chủ của One Tea, chị đang lên kế hoạch tối ưu quy trình bán hàng bằng cách số hóa nó thay vì sử dụng phương pháp truyền thống. Do vậy chị thuê tôi thiết kế một hệ thống bán đồ uống cho cửa hàng. Chị ấy đã giải thích chi tiết vấn đề mà cửa hàng của chị đang phải đối mặt và đưa ra những yêu cầu cho hệ thống. Dưới đây là những yêu cầu của chị về hệ thống bán đồ uống đã được tôi phân tích và tổng hợp lại:

    One Tea is a shop specializing in selling drinks, which is very popular with young people. Their staples are drinks made from coffee and tea. Ms. Trang is the owner of One Tea, she is planning to optimize the sales process by digitizing it instead of using traditional methods. So she hired me to design a system for selling drinks for the store. She explained in detail the problem her store was facing and set out the requirements for the system. Here are your requirements for the beverage sales system that I have analyzed and summarized:

        Beverages that the shop sells are beverages made from coffee and tea (Coffee: back coffee, Cappuccino, Latte, ...| Matcha Latte, Lemon Black Tea, ...).
        The drinks will be displayed as menu.
        Customers can choose the ratio of ingredients in the drink according to the predefined ratios.
        Customers can order more than one drink at a time.
        After choosing, the customer can add or remove the number of drinks in the cart.
        When paying, customers will receive an invoice that includes a list of the drinks they ordered, quantity and total price.
        the system will continue to work after the customer completes payment for an order.
