export function peopleWithAgeDrink(old: number): string {
    return old < 14 ? "drink toddy" : old <= 15 || old < 18 ? "drink coke" : old <= 19 || old === 20 ? "drink beer" : old >= 21 ? "drink whisky" : "have a great day"
    }


    