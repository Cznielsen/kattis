def main():
    current_number = int(input())
    result = []
    while True:
        if current_number == 0:
            break  # end loop when n = 0

        list_first = [int(input()) for _ in range(current_number)] # first list to find solution to
        list_second = [int(input()) for _ in range(current_number)]  # second list (the list to solve).

        first_sort = sorted(list_first)   # sort lists so they can be zipped correctly. Dicts won't work as they cannot contain duplicates
        second_sort = sorted(list_second)

        zipped = list(zip(first_sort, second_sort))
        zipped.sort(key=lambda x: list_first.index(x[0]))  # sort list according to the original first_list
        print("\n".join([str(y) for (x, y) in zipped]))  # from every tuple, select string of second element. Between every operation do new line.
        print()  # extra space between each test

        current_number = int(input())

if __name__ == '__main__':
    main()
