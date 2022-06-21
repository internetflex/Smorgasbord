function prepareQueryString(json) {
    let prefix = "?";
    let query = "";

    for (let index = 0; index < json.length; ++index) {
        const element = json[index];

        if (element.enable) {
            query = query + prefix + element.name+"="+element.value;
            prefix = "&";
        }
    }

    return query;
}

var array =
    [
        { enable: true, name: "id", value: 123 },
        { enable: false, name: "name", value: undefined },
        { enable: true, name: "type", value: "query" }
    ]

console.log(prepareQueryString(array));
alert(prepareQueryString(array));

// Test in JSFiddle.net
