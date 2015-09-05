$(function () {
    var reqTemplate = Handlebars.compile($("#goodsTemplate").html());
    console.log("test");

    var reqsesson = '<%= Session["reqdetails"] %>';

    console.log(reqsesson);
});