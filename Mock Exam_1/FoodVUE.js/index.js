const app = Vue.createApp({
    data() {
        return {
            items: [
                {Id = _id++, InStock = 25, LowLevel = 10, Name = "cookies", lowInStock=0},
                {Id = _id++, InStock = 50, LowLevel = 20, Name = "almonds", lowInStock=0},
                {Id = _id++, InStock = 100, LowLevel = 50, Name = "potatoes", lowInStock=0},
                {Id = _id++, InStock = 300, LowLevel = 100, Name = "tea", lowInStock=0},
                {Id = _id++, InStock = 10, LowLevel = 15, Name = "salad", lowInStock=0}

            ],
            action:
            {
                deleted=false
            }
        }

    },

    methods: {
        deleteFoods() {
            this.action.deleted= true;
        },
        idLowInSTock(_id)
        {
            this.items[_id].lowInStock=InStock-LowLevel;
        }
    }
});
